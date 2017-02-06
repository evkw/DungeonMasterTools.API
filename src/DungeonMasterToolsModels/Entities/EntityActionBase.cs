﻿using System.ComponentModel.DataAnnotations;

namespace DungeonMasterTools.Models.Entities
{
    public class EntityActionBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc  { get; set; }
        public int AttackBonus { get; set; }
    }
}
