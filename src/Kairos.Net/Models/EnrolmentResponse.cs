﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Kairos.Net.Models
{
    public class EnrolmentResponse : BaseResponse
    {
        [JsonProperty("face_id")]
        public string FaceId { get; set; }

        [JsonProperty("images")]
        public IList<EnrolmentImage> Images { get; set; }
    }
}
