using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using Wisej.Hybrid.Client;
using Wisej.Hybrid.Extensions.Desktop;

internal static class Program
{
  [STAThread]
  private static int Main(string[] args)
  {
    if (args.Length < 3) throw new ArgumentException("Pass URL, app name, output path.");
    Application.EnableVisualStyles(); Application.SetCompatibleTextRenderingDefault(false);
    var output = Path.GetFullPath(args[2]); Directory.CreateDirectory(output);
    var report = new JObject { ["app"] = args[1], ["url"] = args[0], ["process64Bit"] = Environment.Is64BitProcess,
      ["packageVersion"] = typeof(HybridDesktopForm).Assembly.GetCustomAttributes(typeof(System.Reflection.AssemblyInformationalVersionAttribute), false).Cast<System.Reflection.AssemblyInformationalVersionAttribute>().FirstOrDefault()?.InformationalVersion };
    var errors = new JArray(); report["errors"] = errors;
    var nativeErrors = new JArray(); report["nativeErrors"] = nativeErrors;
    using var form = new HybridDesktopForm(new HybridClientOptions { StartupUrl = args[0], DebugMode = true }, Path.Combine(output, "webview-data"));
    var preferences = new WindowsHybridPreferencesHandler(Path.Combine(output,"native-data"));
    form.Session.RegisterHandler(preferences);
    form.Session.RegisterInfoProvider(new WindowsHybridSystemInfoProvider(preferences,"Showcase42Acceptance"));
    form.Session.RegisterInfoProvider(new HybridFileSystemInfoProvider(new HybridStoragePaths(Path.Combine(output,"native-data"),Path.Combine(output,"native-cache"))));
    form.Session.UseDesktopExtensions(form);
    var browser = (WebView2)form.Controls[0].Controls[0];
    var exit = 1;
    form.ClientError += (_, ex) => nativeErrors.Add(ex.ToString());
    form.StartupFailed += (_, ex) => { errors.Add(ex.ToString()); form.Close(); };
    form.Shown += async (_, _) =>
    {
      try
      {
        var deadline = DateTime.UtcNow.AddSeconds(65);
        while (browser.CoreWebView2 == null && DateTime.UtcNow < deadline) await Task.Delay(100);
        if (browser.CoreWebView2 == null) throw new TimeoutException("WebView2 initialization.");
        await browser.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.__acceptErrors=[];window.addEventListener('error',e=>window.__acceptErrors.push(e.message));");
        JToken state = JValue.CreateNull();
        while (DateTime.UtcNow < deadline)
        {
          state = JToken.Parse(await browser.ExecuteScriptAsync("(()=>({title:document.title,text:document.body.innerText,online:typeof Wisej!=='undefined'&&!!Wisej.Core&&Wisej.Core.isOnline,bridge:typeof wisej!=='undefined'&&!!wisej.hybrid,errors:window.__acceptErrors||[]}))()"));
          if (state is JObject && (bool?)state["online"] == true)
          {
            var text=(string?)state["text"]??"";
            if(args[1]=="Showcase" ? text.Contains("Integrations")&&!text.Contains("Loading Samples") : text.Length>5)break;
          }
          await Task.Delay(300);
        }
        report["startup"] = state;
        await Task.Delay(500);
        using (var image = File.Create(Path.Combine(output,"startup.png"))) await browser.CoreWebView2.CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat.Png,image);
        if (!(state is JObject) || (bool?)state["online"] != true) throw new Exception("Actual Wisej session did not come online.");
        if (state["text"]!.ToString().Contains("Application Error") || state["text"]!.ToString().Contains("No native handler")) throw new Exception("Application startup reached a missing native API or displayed a server error.");
        report["widgets"] = JToken.Parse(await browser.ExecuteScriptAsync("(()=>{const a=[];const visit=(w,d)=>{if(!w||d>12||a.length>1000)return;let label='';try{label=w.getLabel?w.getLabel():w.getValue?w.getValue():''}catch(e){};a.push({type:w.classname,label:label,id:w.getId?w.getId():null,visible:w.getVisibility?w.getVisibility():null});if(w.getChildren)w.getChildren().forEach(c=>visit(c,d+1));};visit(Wisej.Platform.getRoot(),0);return a})()"));
        if (args[1] == "Showcase")
        {
          if(!args.Contains("--skip-image")) report["browserNativeImage"] = await CheckImageBridge(browser);
          await Click(browser, "Device Info"); await Task.Delay(1500);
          report["deviceInfoText"] = JToken.Parse(await browser.ExecuteScriptAsync("document.body.innerText"));
          if (!report["deviceInfoText"]!.ToString().Contains("System")) throw new Exception("Device Info navigation did not reach its actual view.");
          await Click(browser, "Return to Apps"); await Task.Delay(700);
          await Click(browser, "Preferences"); await Task.Delay(1500);
          report["preferencesText"] = JToken.Parse(await browser.ExecuteScriptAsync("document.body.innerText"));
          using (var image = File.Create(Path.Combine(output,"preferences.png"))) await browser.CoreWebView2.CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat.Png,image);
          if (report["preferencesText"]!.ToString().Contains("No native handler")) throw new Exception("Preferences view reached its native API, which is missing in this candidate.");
          await browser.ExecuteScriptAsync("(()=>{const e=[...document.querySelectorAll('textarea,input')].find(e=>e.getBoundingClientRect().width>0&&!e.readOnly&&!e.disabled);if(!e)throw Error('Preferences editor missing');e.focus();e.select();})()");
          await browser.CoreWebView2.CallDevToolsProtocolMethodAsync("Input.insertText",new JObject{{"text","HYBRID_NET48_SHOWCASE_ACCEPTANCE"}}.ToString(Newtonsoft.Json.Formatting.None));
          await Click(browser,"Save");
          Form? dialog = null;
          for(var i=0;i<60;i++)
          {
            dialog=Application.OpenForms.Cast<Form>().FirstOrDefault(f=>f!=form&&f.Owner==form&&f.Text=="Success");
            if(dialog!=null)break;
            await Task.Delay(100);
          }
          if(dialog==null)throw new Exception("Real Preferences Save did not show its owned native Success alert.");
          var ok=Descendants(dialog).OfType<Button>().FirstOrDefault(b=>b.Text=="OK");
          if(ok==null)throw new Exception("Native alert has no OK button.");
          ok.PerformClick(); report["preferencesNativeSaveAndAlert"]="passed";
          await Task.Delay(300);
          await Click(browser,"Return to Apps");
          await Click(browser,"Storage"); await Task.Delay(800);
          await browser.ExecuteScriptAsync("(()=>{const e=[...document.querySelectorAll('textarea,input')].find(e=>e.getBoundingClientRect().width>0&&!e.readOnly&&!e.disabled);if(!e)throw Error('Storage editor missing');e.focus();e.select();})()");
          await browser.CoreWebView2.CallDevToolsProtocolMethodAsync("Input.insertText",new JObject{{"text","HYBRID_NET48_STORAGE_ACCEPTANCE"}}.ToString(Newtonsoft.Json.Formatting.None));
          await Click(browser,"Save");
          var file=Path.Combine(output,"native-data/sample.txt");
          for(var i=0;i<60&&(!File.Exists(file)||File.ReadAllText(file)!="HYBRID_NET48_STORAGE_ACCEPTANCE");i++)await Task.Delay(100);
          if(!File.Exists(file)||File.ReadAllText(file)!="HYBRID_NET48_STORAGE_ACCEPTANCE")throw new Exception("Showcase native file-system write failed.");
          report["nativeFileSystemWrite"]="passed";
          await Click(browser,"Return to Apps");
          await Click(browser,"Document Scanner");
          await WaitText(browser,"Scan Documents");
          await Click(browser,"Scan Documents");
          var scanner=await OwnedForm(form,"Scan documents");
          var cancel=Descendants(scanner).OfType<Button>().FirstOrDefault(b=>b.Text=="Cancel")??throw new Exception("Document scanner Cancel missing.");
          cancel.PerformClick(); await Task.Delay(700);
          report["documentScannerCancel"]="passed";
          if(args.Contains("--camera"))
          {
            await Click(browser,"Scan Documents"); scanner=await OwnedForm(form,"Scan documents");
            var capture=Descendants(scanner).OfType<Button>().First(b=>b.Text=="Capture");
            var done=Descendants(scanner).OfType<Button>().First(b=>b.Text=="Done");
            for(var i=0;i<150&&!capture.Enabled;i++)await Task.Delay(100);
            if(!capture.Enabled)throw new Exception("Existing camera could not produce a frame: "+string.Join(";",Descendants(scanner).OfType<Label>().Select(l=>l.Text)));
            capture.PerformClick();
            for(var i=0;i<100&&!done.Enabled;i++)await Task.Delay(100);
            if(!done.Enabled)throw new Exception("Actual camera capture did not complete.");
            var pages=(IEnumerable<string>)scanner.GetType().GetProperty("Pages",System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Instance)!.GetValue(scanner)!;
            var jpeg=Convert.FromBase64String(pages.Single());
            using(var bytes=new MemoryStream(jpeg))using(var bitmap=System.Drawing.Image.FromStream(bytes))
            {
              if(bitmap.Width>1280||bitmap.Height>720)throw new Exception("Actual camera result exceeded requested bounds.");
              report["physicalCameraCapture"]=new JObject{{"width",bitmap.Width},{"height",bitmap.Height},{"jpegBytes",jpeg.Length},{"frameWrittenToDisk",false}};
            }
            done.PerformClick(); await WaitText(browser,"Image Preview");
            report["serverImagePreview"]="passed";
          }
        }
        if(args[1]=="Navigation")
        {
          await Click(browser,"Signup");
          await WaitText(browser,"Welcome, John@doe.com");
          await Click(browser,"Return to Login");
          await WaitText(browser,"Email");
          report["signupHomeAndBack"]="passed";
        }
        if(args[1]=="PlatformCode")
        {
          await Click(browser,"Model Name"); await Task.Delay(500);
          report["modelText"]=JToken.Parse(await browser.ExecuteScriptAsync("document.body.innerText"));
          await Click(browser,"Native Dialog");
          var welcome=await OwnedForm(form,"Welcome");
          if(!Descendants(welcome).Any(l=>l.Text=="Hello!"))throw new Exception("Original sample native dialog content missing.");
          Descendants(welcome).OfType<Button>().First(b=>b.Text=="OK").PerformClick();
          report["ownedNativeDialog"]="passed";
        }
        if(args[1]=="LocalDatabase")
        {
          await Click(browser,"Add New Record"); await WaitText(browser,"Add User");
          var inputs=JToken.Parse(await browser.ExecuteScriptAsync("(()=>{window.__dbInputs=[...document.querySelectorAll('input')].filter(e=>e.type!=='checkbox'&&e.getBoundingClientRect().width>0&&!e.readOnly&&!e.disabled).sort((a,b)=>a.getBoundingClientRect().top-b.getBoundingClientRect().top);return window.__dbInputs.map(e=>({value:e.value,top:e.getBoundingClientRect().top}))})()"));
          report["addUserInputs"]=inputs;
          var fields=inputs.OrderBy(t=>(double?)t["top"]).Take(2).ToArray();
          if(fields.Length!=2)throw new Exception("Original Add User input fields missing.");
          for(var i=0;i<2;i++)
          {
            await browser.ExecuteScriptAsync("(()=>{const e=window.__dbInputs["+i+"];e.focus();e.select();})()");
            await browser.CoreWebView2.CallDevToolsProtocolMethodAsync("Input.insertText",new JObject{{"text",i==0?"Net48Acceptance":"SampleRow"}}.ToString(Newtonsoft.Json.Formatting.None));
          }
          await Click(browser,"Add"); await WaitText(browser,"Net48Acceptance");
          report["sqliteAddAndGridRefresh"]="passed";
        }
        if(args[1]=="LocalDatabaseReopen")
        {
          await WaitText(browser,"Net48Acceptance");
          report["sqliteReopenAndServiceRegistration"]="passed";
        }
        if(args[1]=="RemoteWebApiFlow")
        {
          await browser.ExecuteScriptAsync("(()=>{const e=[...document.querySelectorAll('textarea,input')].find(e=>e.getBoundingClientRect().width>0&&!e.readOnly&&!e.disabled);if(!e)throw Error('API value editor missing');e.focus();e.select();})()");
          await browser.CoreWebView2.CallDevToolsProtocolMethodAsync("Input.insertText",new JObject{{"text","NET48_LOCAL_API_ACCEPTANCE"}}.ToString(Newtonsoft.Json.Formatting.None));
          await Click(browser,"Save Data"); await WaitText(browser,"Success: True");
          await Click(browser,"Fetch Data"); await WaitText(browser,"NET48_LOCAL_API_ACCEPTANCE");
          report["localBackendSaveFetch"]="passed";
        }
        if (args[1] == "Baseline")
        {
          await Click(browser, "Verify server event");
          await WaitText(browser,"NET48_SERVER_EVENT_PASS");
          report["serverEvent"] = "passed";
          await Click(browser,"Verify Hybrid bridge");
          await WaitText(browser,"NET48_HYBRID_BRIDGE_PASS");
          report["serverNativeBridge"] = "passed";
        }
        report["result"] = "passed"; exit = 0;
      }
      catch (Exception ex) { errors.Add(ex.ToString()); report["result"] = "failed"; }
      finally { File.WriteAllText(Path.Combine(output,"result.json"),report.ToString()); form.Close(); }
    };
    Application.Run(form);
    Console.WriteLine(report.ToString()); return exit;
  }

  private static IEnumerable<Control> Descendants(Control parent)
  {
    foreach(Control child in parent.Controls)
    { yield return child; foreach(var nested in Descendants(child))yield return nested; }
  }

  private static async Task<Form> OwnedForm(Form owner,string title)
  {
    for(var i=0;i<100;i++)
    {
      var child=Application.OpenForms.Cast<Form>().FirstOrDefault(f=>f!=owner&&f.Owner==owner&&f.Text==title);
      if(child!=null)return child;
      await Task.Delay(100);
    }
    throw new TimeoutException("Expected owned native form: "+title);
  }

  private static async Task<JObject> CheckImageBridge(WebView2 browser)
  {
    const string id="net48-acceptance-quoted-'";
    var quoted=Newtonsoft.Json.JsonConvert.SerializeObject(id);
    await browser.ExecuteScriptAsync("window.mlkit=window.mlkit||{};window.__imageResults=null;window.__imageError=null;window.mlkit["+quoted+"]={isDisposed:()=>false,processResponse:r=>window.__imageResults=r,fireDataEvent:(t,e)=>window.__imageError=e};");
    async Task Send(string encoded)
    {
      await browser.ExecuteScriptAsync("window.__imageResults=null;window.__imageError=null;chrome.webview.postMessage("+Newtonsoft.Json.JsonConvert.SerializeObject(new JObject{{"Id",0},{"ServiceType",-1},{"Handler","mlkit.barcode"},{"Action","process"},{"Arguments",new JArray(id,encoded,350,350)}}.ToString(Newtonsoft.Json.Formatting.None))+");");
      for(var i=0;i<100;i++)
      {
        var response=await browser.ExecuteScriptAsync("window.__imageResults");
        if(response!="null")return;
        await Task.Delay(100);
      }
      throw new TimeoutException("Production browser/native image callback did not arrive.");
    }
    try
    {
      await Send(Convert.ToBase64String(File.ReadAllBytes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Fixtures/qr.png"))));
      var results=JToken.Parse(await browser.ExecuteScriptAsync("window.__imageResults"));
      var qr=results.FirstOrDefault(x=>x["Payload"]?.ToString()=="WISEJ-IMAGE-CHECK")??throw new Exception("Actual browser/native QR image result missing.");
      if((double?)qr["Bounds"]?["Width"]<=0||(double?)qr["Bounds"]?["X"]<0)throw new Exception("Invalid actual QR callback bounds.");
      await Send("invalid-base64");
      var failure=JToken.Parse(await browser.ExecuteScriptAsync("window.__imageError"));
      if(failure.Type==JTokenType.Null||failure.ToString().Length==0)throw new Exception("Corrupt image failed to deliver its correlated browser error.");
      return new JObject{{"syntheticImagePixels",true},{"productionJavaScriptRoute",true},{"qr",qr},{"corruptImageError",failure}};
    }
    finally { await browser.ExecuteScriptAsync("delete window.mlkit["+quoted+"];"); }
  }

  private static async Task WaitText(WebView2 browser,string text)
  {
    for (var i=0;i<80;i++)
    {
      var body=JToken.Parse(await browser.ExecuteScriptAsync("document.body.innerText"))?.ToString()??"";
      if(body.Contains(text)) return;
      await Task.Delay(250);
    }
    throw new TimeoutException("Expected actual application text: "+text);
  }

  private static async Task Click(WebView2 browser,string text)
  {
    var quoted=Newtonsoft.Json.JsonConvert.SerializeObject(text);
    await WaitText(browser,text);
    await Task.Delay(350);
    var raw=await browser.ExecuteScriptAsync("(()=>{const n=[...document.querySelectorAll('*')].find(e=>e.children.length===0&&e.textContent.trim()==="+quoted+"&&e.getBoundingClientRect().width>0);if(!n)return null;n.scrollIntoView({block:'center'});const r=n.getBoundingClientRect();return{x:r.x+r.width/2,y:r.y+r.height/2}})()");
    var point=JToken.Parse(raw);if(point.Type==JTokenType.Null)throw new Exception("Visible actual app control not found: "+text);
    foreach(var type in new[]{"mouseMoved","mousePressed","mouseReleased"})
      await browser.CoreWebView2.CallDevToolsProtocolMethodAsync("Input.dispatchMouseEvent",new JObject{{"type",type},{"x",point["x"]},{"y",point["y"]},{"button","left"},{"clickCount",1}}.ToString(Newtonsoft.Json.Formatting.None));
  }
}
