using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace SkiaTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "Simple Circle";

            SKCanvasView canvasView = new SKCanvasView();
            canvasView.PaintSurface += OnCanvasViewPaintSurface;
            Content = canvasView;
        }

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            SKPath path = new SKPath();
            path.AddPoly(new[]
            {
                new SKPoint(14.707f, 4.70f),
                new SKPoint(6f, 13.414f),
                new SKPoint(1.293f, 8.707f),
                new SKPoint(2.707f, 7.293f),
                new SKPoint(6f, 10.586f),
                new SKPoint(13.293f, 3.293f)
            });

            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = Color.Red.ToSKColor(),
            };
            canvas.Clear();

            canvas.Translate(200, 200);
            canvas.Scale(10, 10);
            canvas.ClipRect(new SKRect(0, 0, 10, 10));
            canvas.Clear(SKColors.AliceBlue);

            canvas.DrawPath(path, paint);
        }
    }
}

