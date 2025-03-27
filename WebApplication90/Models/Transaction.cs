using System.ComponentModel.DataAnnotations;

namespace WebApplication90.Models;

public class Transaction
{
    public int Id { get; set; }

    [Required]
    public int ProductId { get; set; }
    public Product? Product { get; set; }

    [Required]
    public TransactionType Type { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

    [StringLength(500)]
    public string? Notes { get; set; }

    [Required]
    public string UserId { get; set; } = string.Empty;
}

public enum TransactionType
{
    In,
    Out
} 