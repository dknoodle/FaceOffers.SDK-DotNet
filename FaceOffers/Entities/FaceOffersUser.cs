﻿using FaceOffers.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffers
{
    public class FaceOffersUser : FaceOffersObject
    {
        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("Address1")]
        public string Address1 { get; set; }

        [JsonProperty("Address2")]
        public string Address2 { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("ZipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("DateRegistered")]
        [JsonConverter(typeof(FaceOffersDateTimeConverter))]
        public DateTime? DateRegistered { get; set; }

        [JsonProperty("LastLogin")]
        [JsonConverter(typeof(FaceOffersDateTimeConverter))]
        public DateTime? LastLogin { get; set; }
    }
}