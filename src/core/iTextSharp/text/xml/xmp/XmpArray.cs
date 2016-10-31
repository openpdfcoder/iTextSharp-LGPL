using System;
using System.Collections;
using System.Text;
/*
 * $Id: XmpArray.cs,v 1.3 2008/05/13 11:26:16 psoares33 Exp $
 * 
 *
 * Copyright 2005 by Bruno Lowagie.
 *
 * The contents of this file are subject to the Mozilla Public License Version 1.1
 * (the "License"); you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the License.
 *
 * The Original Code is 'iText, a free JAVA-PDF library'.
 *
 * The Initial Developer of the Original Code is Bruno Lowagie. Portions created by
 * the Initial Developer are Copyright (C) 1999-2005 by Bruno Lowagie.
 * All Rights Reserved.
 * Co-Developer of the code is Paulo Soares. Portions created by the Co-Developer
 * are Copyright (C) 2000-2005 by Paulo Soares. All Rights Reserved.
 *
 * Contributor(s): all the names of the contributors are added in the source code
 * where applicable.
 *
 * Alternatively, the contents of this file may be used under the terms of the
 * LGPL license (the "GNU LIBRARY GENERAL PUBLIC LICENSE"), in which case the
 * provisions of LGPL are applicable instead of those above.  If you wish to
 * allow use of your version of this file only under the terms of the LGPL
 * License and not to allow others to use your version of this file under
 * the MPL, indicate your decision by deleting the provisions above and
 * replace them with the notice and other provisions required by the LGPL.
 * If you do not delete the provisions above, a recipient may use your version
 * of this file under either the MPL or the GNU LIBRARY GENERAL PUBLIC LICENSE 
 *
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the MPL as stated above or under the terms of the GNU
 * Library General Public License as published by the Free Software Foundation;
 * either version 2 of the License, or any later version.
 *
 * This library is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 * FOR A PARTICULAR PURPOSE. See the GNU LIBRARY GENERAL PUBLIC LICENSE for more
 * details.
 *
 * If you didn't download this code from the following link, you should check if
 * you aren't using an obsolete version:
 * http://www.lowagie.com/iText/
 */

namespace iTextSharp.text.xml.xmp
{

    /**
    * StringBuilder to construct an XMP array.
    */
    public class XmpArray : ArrayList {

        /** An array that is unordered. */
        public const String UNORDERED = "rdf:Bag";
        /** An array that is ordered. */
        public const String ORDERED = "rdf:Seq";
        /** An array with alternatives. */
        public const String ALTERNATIVE = "rdf:Alt";
        
        /** the type of array. */
        protected String type;
        
        /**
        * Creates an XmpArray.
        * @param type the type of array: UNORDERED, ORDERED or ALTERNATIVE.
        */
        public XmpArray(String type) {
            this.type = type;
        }
        
        /**
        * Returns the String representation of the XmpArray.
        * @return a String representation
        */
        public override String ToString() {
            StringBuilder buf = new StringBuilder("<");
            buf.Append(type);
            buf.Append('>');
            foreach (String s in this) {
                buf.Append("<rdf:li>");
                buf.Append(XmpSchema.Escape(s));
                buf.Append("</rdf:li>");
            }
            buf.Append("</");
            buf.Append(type);
            buf.Append('>');
            return buf.ToString();
        }
    }
}