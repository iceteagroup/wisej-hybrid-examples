Run `dotnet run --project tests/ShowcaseVideo/ShowcaseVideo.csproj`.

These checks compile the actual Showcase video handler and byte-range parser with minimal UI/HTTP adapters. They verify full responses, Safari's two-byte probe, bounded/open-ended/suffix ranges, out-of-bounds and malformed requests, HEAD, unsupported methods, and release of the video on disposal. The main Showcase builds validate against the real Wisej APIs; device playback and seeking remain runtime checks.
