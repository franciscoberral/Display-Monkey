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
    
    public partial class Content
    {
        public Content()
        {
            this.Canvas = new HashSet<Canvas>();
            this.Pictures = new HashSet<Picture>();
            this.Videos = new HashSet<Video>();
        }
    
        public int ContentId { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public ContentTypes Type { get; set; }
        public byte[] Version { get; set; }
    
        public virtual ICollection<Canvas> Canvas { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
