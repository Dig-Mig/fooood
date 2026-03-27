using System.ComponentModel.DataAnnotations;

namespace DataAcessLayer.Models;

public class Madplan
{
    public int Id { get; set; }
    
    [Required]
    public int Uge { get; set; }
    public int år { get; set; }
    public virtual Recipe Mandag { get; set; } 
    public virtual Recipe Tisdag { get; set; } 
    public virtual Recipe Onsdag { get; set; } 
    public virtual Recipe Torsdag { get; set; } 
    public virtual Recipe Fredag { get; set; } 
    public virtual Recipe Lørdag { get; set; } 
    public virtual Recipe Søndag { get; set; } 
}