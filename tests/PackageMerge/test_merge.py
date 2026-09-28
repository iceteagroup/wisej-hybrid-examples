"""Regression checks for merging platform slices without changing NuGet identity."""
from pathlib import Path
import subprocess
import sys
import tempfile
import unittest
import xml.etree.ElementTree as ET
from zipfile import ZipFile


SCRIPT = Path(__file__).resolve().parents[2] / 'build' / 'Merge-LocalHybrid.py'
NS = 'http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd'


class MergeTests(unittest.TestCase):
    def test_preserves_default_namespace_identity_dependencies_and_binary_assets(self):
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary)
            for platform in ('windows', 'ios'):
                folder = root / platform
                folder.mkdir()
                spec = f'''<package xmlns="{NS}"><metadata><id>Example</id>
<version>1.0.0</version><authors>Test</authors><description>Test</description>
<dependencies><group targetFramework="net9.0-{platform}">
<dependency id="Dependency" version="1.0.0" /></group></dependencies>
</metadata></package>'''
                with ZipFile(folder / 'Example.1.0.0.nupkg', 'w') as package:
                    package.writestr('Example.nuspec', spec)
                    package.writestr(f'lib/net9.0-{platform}/Example.dll', platform.encode())
            subprocess.run([sys.executable, str(SCRIPT), str(root / 'windows'),
                            str(root / 'ios'), str(root / 'merged')], check=True, capture_output=True)
            with ZipFile(root / 'merged' / 'Example.1.0.0.nupkg') as package:
                spec = package.read('Example.nuspec')
                self.assertNotIn(b'ns0:', spec)
                self.assertIn(f'<package xmlns="{NS}"'.encode(), spec)
                metadata = ET.fromstring(spec).find(f'{{{NS}}}metadata')
                self.assertEqual(metadata.findtext(f'{{{NS}}}id'), 'Example')
                self.assertEqual(metadata.findtext(f'{{{NS}}}version'), '1.0.0')
                self.assertEqual(len(metadata.findall(f'{{{NS}}}dependencies/{{{NS}}}group')), 2)
                for platform in ('windows', 'ios'):
                    self.assertEqual(package.read(f'lib/net9.0-{platform}/Example.dll'), platform.encode())


if __name__ == '__main__':
    unittest.main()
