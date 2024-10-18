using System.ComponentModel.DataAnnotations; // Importing data annotations for validation attributes.
using System.ComponentModel.DataAnnotations.Schema; // Importing annotations for schema-related attributes.

namespace Nikhil_PART2_PROG6212_CMCSF.Models // Defining the namespace for the project.
{
    // Defining the 'Claim' class to represent a claim submitted by a lecturer.
    public class Claim
    {
        // Primary key for the Claim entity.
        [Key]
        public int ClaimId { get; set; }

        // Stores the name of the lecturer who submitted the claim.
        [Required] // This field is mandatory.
        public string LecturerName { get; set; }

        // Stores the number of hours worked by the lecturer.
        [Required] // This field is mandatory.
        [Range(0, double.MaxValue)] // Ensures that the value is non-negative.
        public double HoursWorked { get; set; }

        // Stores the hourly rate for the lecturer.
        [Required] // This field is mandatory.
        [Range(0, double.MaxValue)] // Ensures the rate is non-negative.
        public double HourlyRate { get; set; }

        // Optional field to store any notes related to the claim.
        public string Notes { get; set; }

        // Tracks the status of the claim (e.g., Pending, Approved, or Rejected).
        [Required] // This field is mandatory.
        public string Status { get; set; } = "Pending"; // Default status is set to "Pending".

        // Stores the file path for supporting documents related to the claim.
        [Required] // This field is mandatory.
        public string? DocumentPath { get; set; } // Allows null to account for cases where the document might not be uploaded initially.
    }
}
// code attribution // W3schools // https://www.w3schools.com/cs/index.php

// code attribution //Microsoft //https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started

// code attribution //Microsoft //https://learn.microsoft.com/en-us/azure/storage/blobs/storage-blob-dotnet-get-started?tabs=azure-ad

// code attribution //Bootswatch //https://bootswatch.com/
