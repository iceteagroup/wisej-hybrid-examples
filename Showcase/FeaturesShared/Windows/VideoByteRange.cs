using System;
using System.Globalization;

namespace FeaturesShared.Windows
{
	/// <summary>A single HTTP byte range over an in-memory video.</summary>
	internal readonly struct VideoByteRange
	{
		private VideoByteRange(int statusCode, int offset, int count)
		{
			StatusCode = statusCode;
			Offset = offset;
			Count = count;
		}

		internal int StatusCode { get; }
		internal int Offset { get; }
		internal int Count { get; }

		internal static VideoByteRange Parse(string header, int length)
		{
			if (length < 0) throw new ArgumentOutOfRangeException(nameof(length));
			var full = new VideoByteRange(200, 0, length);
			var invalid = new VideoByteRange(416, 0, 0);
			if (string.IsNullOrWhiteSpace(header)) return full;

			header = header.Trim();
			if (!header.StartsWith("bytes=", StringComparison.OrdinalIgnoreCase)) return full;
			// Multiple ranges are optional; return the full representation instead of multipart data.
			var range = header.Substring(6).Trim();
			if (range.Contains(",")) return full;
			var separator = range.IndexOf('-');
			if (separator < 0 || length == 0) return invalid;

			var first = range.Substring(0, separator).Trim();
			var last = range.Substring(separator + 1).Trim();
			if (first.Length == 0)
			{
				if (!TryNumber(last, out var suffix) || suffix == 0) return invalid;
				var count = (int)Math.Min(suffix, length);
				return new VideoByteRange(206, length - count, count);
			}

			if (!TryNumber(first, out var start) || start >= length) return invalid;
			long end = length - 1;
			if (last.Length > 0 && (!TryNumber(last, out end) || end < start)) return invalid;
			end = Math.Min(end, length - 1);
			return new VideoByteRange(206, (int)start, (int)(end - start + 1));
		}

		private static bool TryNumber(string value, out long number)
		{
			return long.TryParse(value, NumberStyles.None, CultureInfo.InvariantCulture, out number);
		}
	}
}
