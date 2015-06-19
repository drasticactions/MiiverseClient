﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mntone.MiiverseClient.Entities.Community
{
    [DataContract]
    public sealed class Game
    {
        internal Game(string id, string title, string titleUrl, Uri iconUri, string platform, string type)
        {
            Id = id;
            Title = title;
            TitleUrl = titleUrl;
            IconUri = iconUri;
            Platform = GamePlatformHelper.DetectPlatformFromImageName(platform);
            Type = type;
        }

        [DataMember(Name = "id")]
        public string Id { get; }

        [DataMember(Name = "title")]
        public string Title { get; }

        [DataMember(Name = "title_url")]
        public string TitleUrl { get; }

        [DataMember(Name = "icon_uri")]
        public Uri IconUri { get; }

        [DataMember(Name = "platform")]
        public Platform Platform { get; }

        [DataMember(Name = "type")]
        public string Type { get; }
    }
}
