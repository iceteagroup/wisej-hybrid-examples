using System;
using System.Reflection;

namespace Wisej.Hybrid.Features
{
	public class UnsupportedAttribute : Attribute
	{
		public UnsupportedAttribute(string platform) 
		{
			this.Platform = platform;
		}

		public string Platform { get; set; }

		public static bool IsSupported(Type type, string platform)
		{
			var attributes = type.GetCustomAttributes(typeof(UnsupportedAttribute));

			foreach (var attribute in attributes) 
			{
				if (attribute is UnsupportedAttribute unsupportedAttribute)
					if (unsupportedAttribute.Platform == platform)
						return false;					
			}

			return true;
		}
	}
}
