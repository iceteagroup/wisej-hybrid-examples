using System;
using System.Linq;
using System.Reflection;

namespace Wisej.Hybrid.Features
{
	public class UnsupportedAttribute : Attribute
	{
		public UnsupportedAttribute(params string[] platforms) 
		{
			this.Platforms = platforms;
		}

		public string[] Platforms { get; set; }

		public static bool IsSupported(Type type, string platform)
		{
			var attributes = type.GetCustomAttributes(typeof(UnsupportedAttribute));

			foreach (var attribute in attributes) 
			{
				if (attribute is UnsupportedAttribute unsupportedAttribute)
					if (unsupportedAttribute.Platforms.Contains(platform))
						return false;					
			}

			return true;
		}
	}
}
