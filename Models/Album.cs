using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CdAlbum.Models
{
    public class Album
    {
        public int Id { get; set; }

        [DisplayName("Namn på album")]
        [Required(ErrorMessage = "Du måste ange namn på album.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Du måste ange mellan 2 och 50 tecken. ")]
        public string AlbumName { get; set; }

        [DisplayName("Artist/band")]
        [Required(ErrorMessage = "Du måste ange namn på Artist/band.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Du måste ange mellan 2 och 50 tecken. ")]
        public string Artist { get; set; }

        [DisplayName("Årtal")]
        [Required(ErrorMessage = "Du måste ange årtal då skivan släpptes.")]
        [Range(1920, 2200, ErrorMessage = "Ditt årtal är ogiltigt. Kolla att du har skrivit ett korrekt årtal då skivan släpptes.")]
        public int ReleaseYear { get; set; }

        public Album()
        {
        }
    }
}
