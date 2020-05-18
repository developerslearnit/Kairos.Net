﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Kairos.Net.Models
{
    public class RecognitionResponse : BaseResponse
    {
        [JsonProperty("images")]
        public IList<RecognitionImage> Images { get; set; }
    }
}
