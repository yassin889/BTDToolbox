﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do one of these:
//
//    using QuickType;
//
//    var artist = Artist.FromJson(jsonString);
//    var album = Album.FromJson(jsonString);
//    var track = Track.FromJson(jsonString);

namespace Tower_Class
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Artist
    {
        [JsonProperty("AircraftList", NullValueHandling = NullValueHandling.Ignore)]
        public object[] AircraftList { get; set; }

        [JsonProperty("BaseCost", NullValueHandling = NullValueHandling.Ignore)]
        public long? BaseCost { get; set; }

        [JsonProperty("CanBePlacedInWater", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanBePlacedInWater { get; set; }

        [JsonProperty("CanBePlacedOnLand", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanBePlacedOnLand { get; set; }

        [JsonProperty("CanBePlacedOnPath", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanBePlacedOnPath { get; set; }

        [JsonProperty("CanTargetCamo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanTargetCamo { get; set; }

        [JsonProperty("DefaultWeapons", NullValueHandling = NullValueHandling.Ignore)]
        public string[] DefaultWeapons { get; set; }

        [JsonProperty("ActiveWeaponSlots", NullValueHandling = NullValueHandling.Ignore)]
        public bool[] ActiveWeaponSlots { get; set; }

        [JsonProperty("Icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        [JsonProperty("Description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("PlacementH", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlacementH { get; set; }

        [JsonProperty("PlacementRadius", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlacementRadius { get; set; }

        [JsonProperty("PlacementW", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlacementW { get; set; }

        [JsonProperty("RankToUnlock", NullValueHandling = NullValueHandling.Ignore)]
        public long? RankToUnlock { get; set; }

        [JsonProperty("RotatesToTarget", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RotatesToTarget { get; set; }

        [JsonProperty("TargetIsWeaponOrigin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TargetIsWeaponOrigin { get; set; }

        [JsonProperty("TargetingMode", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetingMode { get; set; }

        [JsonProperty("TargetsManually", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TargetsManually { get; set; }

        [JsonProperty("TypeName", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeName { get; set; }

        [JsonProperty("Upgrades", NullValueHandling = NullValueHandling.Ignore)]
        public string[][] Upgrades { get; set; }

        [JsonProperty("UpgradeDescriptions", NullValueHandling = NullValueHandling.Ignore)]
        public string[][] UpgradeDescriptions { get; set; }

        [JsonProperty("ShortUpgradeDescriptions", NullValueHandling = NullValueHandling.Ignore)]
        public string[][] ShortUpgradeDescriptions { get; set; }

        [JsonProperty("UpgradeGateway", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeGateway[][] UpgradeGateway { get; set; }

        [JsonProperty("UpgradePrices", NullValueHandling = NullValueHandling.Ignore)]
        public long[][] UpgradePrices { get; set; }

        [JsonProperty("UpgradeIcons", NullValueHandling = NullValueHandling.Ignore)]
        public string[][] UpgradeIcons { get; set; }

        [JsonProperty("UpgradeAvatars", NullValueHandling = NullValueHandling.Ignore)]
        public string[][] UpgradeAvatars { get; set; }

        [JsonProperty("UseRadiusPlacement", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseRadiusPlacement { get; set; }

        [JsonProperty("SpriteUpgradeDefinition", NullValueHandling = NullValueHandling.Ignore)]
        public string SpriteUpgradeDefinition { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("founded", NullValueHandling = NullValueHandling.Ignore)]
        public long? Founded { get; set; }

        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Members { get; set; }
    }

    public partial class UpgradeGateway
    {
        [JsonProperty("Rank")]
        public long Rank { get; set; }

        [JsonProperty("XP")]
        public long Xp { get; set; }
    }

    public partial class Album
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("artist")]
        public ArtistClass Artist { get; set; }

        [JsonProperty("tracks")]
        public Track[] Tracks { get; set; }
    }

    public partial class ArtistClass
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("founded")]
        public long Founded { get; set; }

        [JsonProperty("members")]
        public string[] Members { get; set; }
    }

    public partial class Track
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }
    }

    public partial class Artist
    {
        public static Artist FromJson(string json) => JsonConvert.DeserializeObject<Artist>(json, QuickType.Converter.Settings);
    }

    public partial class Album
    {
        public static Album FromJson(string json) => JsonConvert.DeserializeObject<Album>(json, QuickType.Converter.Settings);
    }

    public partial class Track
    {
        public static Track FromJson(string json) => JsonConvert.DeserializeObject<Track>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Artist self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
        public static string ToJson(this Album self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
        public static string ToJson(this Track self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
