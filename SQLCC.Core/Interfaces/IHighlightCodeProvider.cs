﻿using System.Collections.Generic;
using SQLCC.Core.Objects;

namespace SQLCC.Core.Interfaces
{
   internal interface IHighlightCodeProvider
   {
      string HighlightCode(string code, List<DbCodeSegment> codeSegments);
   }
}
