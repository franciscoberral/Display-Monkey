/*!
* DisplayMonkey source file
* http://displaymonkey.org
*
* Copyright (c) 2019 Fuel9 LLC and contributors
*
* Released under the MIT license:
* http://opensource.org/licenses/MIT
*/

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DisplayMonkey.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Template
    {
        public Template()
        {
            this.Frames = new HashSet<Frame>();
        }
    
        public int TemplateId { get; set; }
        public string Name { get; set; }
        public string Html { get; set; }
        public FrameTypes FrameType { get; set; }
        public byte[] Version { get; set; }
    
        public virtual ICollection<Frame> Frames { get; set; }
    }
}
