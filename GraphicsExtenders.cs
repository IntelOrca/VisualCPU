using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace VisualCPU
{
	static class GraphicsExtenders
	{
		const bool SLOWWAY = true;

		public static void FillEllipseWrap(this Graphics g, Brush brush, float x, float y, float width, float height, Rectangle bounds)
		{
			if (!SLOWWAY) {
				g.FillEllipse(brush, x, y, width, height);
				return;
			}

			g.FillEllipse(brush, x - bounds.Width	, y - bounds.Height	, width, height);
			g.FillEllipse(brush, x					, y - bounds.Height	, width, height);
			g.FillEllipse(brush, x + bounds.Width	, y - bounds.Height	, width, height);

			g.FillEllipse(brush, x - bounds.Width, y, width, height);
			g.FillEllipse(brush, x,	y, width, height);
			g.FillEllipse(brush, x + bounds.Width, y, width, height);

			g.FillEllipse(brush, x - bounds.Width, y + bounds.Height, width, height);
			g.FillEllipse(brush, x, y + bounds.Height, width, height);
			g.FillEllipse(brush, x + bounds.Width, y + bounds.Height, width, height);
		}

		public static void DrawStringWrap(this Graphics g, string text, Font font, Brush brush, float x, float y, Rectangle bounds)
		{
			if (!SLOWWAY) {
				g.DrawString(text, font, brush, x, y);
				return;
			}

			g.DrawString(text, font, brush, x - bounds.Width, y - bounds.Height);
			g.DrawString(text, font, brush, x, y - bounds.Height);
			g.DrawString(text, font, brush, x + bounds.Width, y - bounds.Height);

			g.DrawString(text, font, brush, x - bounds.Width, y);
			g.DrawString(text, font, brush, x, y);
			g.DrawString(text, font, brush, x + bounds.Width, y);

			g.DrawString(text, font, brush, x - bounds.Width, y + bounds.Height);
			g.DrawString(text, font, brush, x, y + bounds.Height);
			g.DrawString(text, font, brush, x + bounds.Width, y + bounds.Height);
		}
	}
}
