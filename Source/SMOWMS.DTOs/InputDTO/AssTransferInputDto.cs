using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    public class AssTransferInputDto:IEntity
    {
        [Required]
        public string WAREID { get; set; }

        [Required]
        public string STID { get; set; }

        [Required]
        public string SLID { get; set; }

        public List<string> SnList { get; set; }

        public string UserId { get; set; }
    }
}