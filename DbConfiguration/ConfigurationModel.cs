﻿
using SqlBase;
using SQLite;

namespace Utils.Models
{
    public class ConfigurationModel : IValueObject
    {
        [PrimaryKey]
        public string Id { get; set; }

        public string Value { get; set; }
    }
}