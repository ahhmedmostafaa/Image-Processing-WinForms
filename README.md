# Image Processing Desktop App (C# WinForms)

A Windows desktop application implementing core image processing operations from scratch at the pixel level, built with C# and WinForms.

## Features

- **RGB Channel Manipulation** — isolate and manipulate individual Red, Green, and Blue channels of a loaded image
- **Grayscale Conversion** — pixel-by-pixel grayscale transformation
- **Histogram Analysis** — computes and displays per-channel (R/G/B) pixel intensity distributions
- **Histogram Equalization** — contrast enhancement by redistributing intensity values across the histogram
- **Image Loading via OpenCV bindings** — supports JPEG, PNG, BMP, GIF, TIFF, WebP, and HEIC formats

## How it works
Each processing form (`Form1`, `FormRGB`, `FormGrayscale`, `FormHistogram`) works directly on the loaded bitmap's pixel data — reading and modifying RGB values pixel-by-pixel rather than relying on built-in image filters, to demonstrate the underlying image processing algorithms.

## Tech Stack
- C# / .NET WinForms
- OpenCV (via native `cvlib` bindings) for image loading/resizing
- System.Drawing (Bitmap manipulation)

## How to Run
1. Open `ImageProcessing.sln` in Visual Studio
2. Restore/build the solution
3. Run (F5)
4. Use **File → Open** to load an image, then apply the desired transformation from the menu

## Roadmap
- [ ] Add more filters (blur, edge detection, sharpening)
- [ ] Add before/after screenshots to this README
- [ ] Optimize pixel loops (currently uses `GetPixel`/`SetPixel`, which is slow for large images — `LockBits` would be significantly faster)

---
*Originally built for an "Image Processing" university course; refined for portfolio presentation.*
