﻿using System.Diagnostics.CodeAnalysis;

namespace TechTalk.JiraRestClient.Dto
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class JiraUser
    {
        public string self { get; set; }
        public string name { get; set; }
        public string emailAddress { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public AvatarUrls avatarUrls { get; set; }
    }
}
