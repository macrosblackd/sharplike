///////////////////////////////////////////////////////////////////////////////
/// Sharplike, The Open Roguelike Library (C) 2010 2010 Ed Ropple.          ///
///                                                                         ///
/// This code is part of the Sharplike Roguelike library, and is licensed   ///
/// under the Common Public Attribution License (CPAL), version 1.0. Use of ///
/// this code is purusant to this license. The CPAL grants you certain      ///
/// permissions and requirements and should be read carefully before using  ///
/// this library.                                                           ///
///                                                                         ///
/// A copy of this license can be found in the Sharplike root directory,    ///
/// and must be included with all projects released using this library.     ///
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Drawing;

namespace Sharplike.Core.Rendering
{
	[Serializable]
	public class RawGlyphProvider : IGlyphProvider
	{
		private Glyph[] glyphs;
		private Color background = Color.Black;

		public RawGlyphProvider (Glyph g, Color c)
		{
			background = c;
			glyphs = new Glyph[1];
			glyphs[0] = g;
		}

        public Color BackgroundColor
        {
			get { return background; }
        }

        public Glyph[] Glyphs
        {
			get { return glyphs; }
        }

        public bool Dirty
        {
            get { return false; }
        }
    }
}
