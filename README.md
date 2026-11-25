<p align="center">
  <a href="https://archnet-plateform.fr"><img src="https://archnet-plateform.fr/ArchNetLogoWithBck.png" alt="ArchNet" width="240"></a>
</p>

# ArchNet · ScrollRect Extension

Extension methods for scroll views: jump to an edge, lock scrolling, tell a horizontal drag from a vertical one.

- Unity **6000.0** or newer · No dependency.
- Part of [ArchNet](https://archnet-plateform.fr), free and open-source Unity packages

## Install

*Window > Package Manager > + > Install package from git URL…*

```
https://github.com/ArchNet-1/ScrollRectExtension.git
```

## Use

```csharp
using ArchNet.Extension;

scrollRect.ScrollToTop();
scrollRect.LockScroll();
if (eventData.IsHorizontalDrag()) …
```

## License

See [LICENSE.md](LICENSE.md).
