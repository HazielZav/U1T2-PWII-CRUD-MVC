using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace U1T2_CRUD_MVC.Models;

public partial class Product
{
    public int ProductId { get; set; }

    [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
    [StringLength(40, MinimumLength = 2, ErrorMessage = "El nombre de producto debe estar entre 2 y 40 caracteres.")]
    [Display(Name ="Nombre del producto")]
    public string ProductName { get; set; } = null!;

    [Display(Name = "Proveedor")]
    public int? SupplierId { get; set; }

    [Display(Name = "Categoría")]
    public int? CategoryId { get; set; }

    [Display(Name = "Cantidad por unidad")]
    public string? QuantityPerUnit { get; set; }

    [Display(Name = "Precio unitario")]
    public decimal? UnitPrice { get; set; }

    [Display(Name = "Unidades en stock")]
    public short? UnitsInStock { get; set; }

    [Display(Name = "Unidades en orden")]
    public short? UnitsOnOrder { get; set; }

    [Display(Name = "Nivel de reorden")]
    public short? ReorderLevel { get; set; }

    
    public ulong Discontinued { get; set; }
    [Display(Name = "Estado")]
    public string Estado => Discontinued == 1 ? "Descontinuado" : "Activo";

    public virtual Category? Category { get; set; }

    public virtual ICollection<Orderdetail> Orderdetails { get; set; } = new List<Orderdetail>();

    public virtual Supplier? Supplier { get; set; }
}
