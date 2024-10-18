 -Contract Monthly Claim System (CMCS) 

-Overview

The Contract Monthly Claim System (CMCS) is a .NET web-based application developed to simplify the process of submitting and approving monthly claims for Independent Contractor (IC) lecturers. 
This system aims to streamline the entire workflow, from creating and submitting claims to approving or rejecting them, ensuring efficiency, transparency, and accountability. With a user-centric design,
CMCS provides separate functionalities tailored for lecturers, coordinators, and managers, enabling a smooth and seamless claim management process. Through the CMCS, lecturers can submit multiple claims 
with attached supporting documents, track the status of their submissions, and review their claim history. Meanwhile, coordinators and managers play a crucial role in reviewing, approving, or rejecting 
these claims, providing feedback when necessary. The system is designed to reduce administrative burdens by automating routine processes, allowing users to focus on more strategic activities. 
This README outlines the key functions available to each user role and explains how the system operates to support efficient claim management.

- Lecturer Functions

As primary users of the system, Lecturers are responsible for creating claims that accurately reflect the hours
they have worked. These claims must be accompanied by supporting documents to verify the work completed. The system 
provides several features to ensure the lecturers' smooth and efficient experience.

- Submit Claims with Supporting Documents  
Lecturers can create and submit claims by providing essential details such as the hours worked and the
applicable hourly rate. Every claim submission requires a supporting document, such as a Word document (.docx), PDF
(.pdf), or Excel file (.xlsx), to validate the claim. To maintain efficiency, the system imposes a file size limit of
 5 MB, ensuring that uploads remain manageable.

- Track Claim Status  
After submission, lecturers can access a status page that displays the current state of their claims.
 Claims can have one of three statuses: Pending, Approved ,
 or Rejected. This feature ensures transparency, keeping lecturers informed about the progress of their submissions.

- View Claim History  
Lecturers have access to a complete history of their submitted claims, including the date of submission, status updates, and
 any supporting documents uploaded. This allows them to keep track of their claims and review the reasons for any
 rejections, helping them resubmit corrected claims if needed.

-Create Multiple Claims  
The system allows lecturers to submit as many claims as needed, without limitations. This flexibility is particularly
beneficial for lecturers managing multiple projects or engagements, ensuring all their work is appropriately accounted for.


- Coordinator and Manager Functions

Coordinators and managers share responsibility for reviewing, approving, or rejecting claims submitted by lecturers. These roles 
are essential in maintaining the accuracy and integrity of the system by ensuring that only valid claims are approved. Both roles 
have access to similar functions within the application.

-View Pending Claims  
Coordinators and managers can access a list of all pending claims awaiting their action. Claims are organized by submission date, 
helping users prioritize reviews efficiently. The ability to view all pending claims ensures that no submission goes unnoticed, 
maintaining a streamlined workflow.

- Approve Claims  
After reviewing a claim and verifying the hours worked, the supporting documents, and the calculations, coordinators or managers can
approve the claim. Approved claims are updated in the system with the status **Approved**, and the lecturer is notified. This process
ensures accurate and fair compensation for the work completed.

-Reject Claims  
If there are issues or discrepancies with a claim, such as missing documents or incorrect calculations, coordinators or managers can reject 
the claim. The system provides an option to leave feedback, which is visible to the lecturer. This feedback helps the lecturer understand what
needs to be corrected before resubmitting the claim. Rejected claims are marked **Rejected**, promoting accountability and continuous improvement.

-------------------------------------------------------------------------------------------------------------------------------------------------------

--Technical Overview
The CMCS is built using **ASP.NET Core MVC**, a powerful framework for developing modern web applications. It leverages C# for back-end functionality, 
with role-based authentication to ensure secure access to specific pages based on the user's role. The system stores claim data and user information in an in-memory database
during development, which can later be replaced with a more permanent SQL database for production use. Uploaded documents are stored in the wwwroot/uploads folder, ensuring 
easy access and organization of supporting files.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- User Interface Overview

The CMCS system features an intuitive and role-specific user interface to enhance usability. Each role—lecturer, coordinator, and manager—has access to unique pages tailored 
to their responsibilities, ensuring that users can efficiently complete their tasks.

--- Homepage  
The homepage provides an overview of the system, with login options for lecturers, coordinators, and managers. Once logged in, users are directed to their respective dashboards
based on their role.

-- Submit Claim Page, out Lecturer)  
Lecturers can fill out a form on this page, providing details of their work and uploading supporting documents. The page includes real-time validation to ensure the 
uploaded files meet the size and type requirements. This helps lecturers submit accurate claims without encountering errors.

### Pending Claims Page (Coordinator/Manager)  
Coordinators and managers can access the pending claims page, where they can review each claim in detail. The page provides options to approve or reject claims, with space to 
leave feedback when necessary. This feature ensures that only valid claims are approved, maintaining accountability.

--Claims History Page ,our lecturer  
This page displays a list of all claims submitted by the lecturer, with relevant details such as submission date, status, and any feedback provided. Lecturers can also download
their uploaded documents from this page for reference or resubmission.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- Workflow Summary

The CMCS system ensures smooth collaboration between lecturers, coordinators, and managers through the following workflow:

1. Lecturer:  
   - Submit a claim with supporting documents.  
   - Tracks the status of the claim through the system.  
   - Reviews rejected claims and resubmits corrected versions if needed.

2. **Coordinator/Manager**:  
   - Reviews pending claims submitted by lecturers.  
   - Approves valid claims, marking them as **Approved** in the system.  
   - Rejects invalid claims, providing feedback to help lecturers improve their submissions.  

This workflow ensures that claims are processed efficiently while maintaining accuracy and accountability.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 Error Handling and Validation

The CMCS system includes robust error handling and validation to enhance reliability:

- File Validation: The system checks uploaded files to ensure they are in the correct format (PDF, DOCX, XLSX) and do not exceed the 5 MB size limit.  
- Authentication: Role-based authentication ensures that only authorized users can access specific pages, protecting sensitive data.  
- Error Pages: Friendly error messages guide users if an operation fails, such as when a rejected claim cannot be updated.

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 Benefits of the CMCS System

The CMCS system offers numerous benefits, including streamlined workflows, improved accuracy, and enhanced accountability.
By automating routine tasks such as claim tracking and approval, the system reduces administrative burden and ensures transparency in the process. Lecturers, coordinators, and managers
all benefit from an intuitive interface tailored to their specific needs, empowering them to perform their roles efficiently.
This system also promotes continuous improvement by providing feedback on rejected claims, helping lecturers correct and resubmit their work. 
The combination of automation, role-based access, and real-time status tracking makes CMCS a valuable tool for managing monthly claims in an organized and efficient manner.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 Conclusion

The Contract Monthly Claim System (CMCS)** provides a comprehensive solution for managing monthly claims submitted by Independent Contractor lecturers.
By streamlining the process of claim submission, review, and approval, the system promotes efficiency, transparency, and accountability. With its user-centric design and role-specific features,
CMCS ensures that all users can perform their tasks effectively.  Through hands-on interaction with the system, users gain practical experience in .NET Core development and learn to apply best practices in software design. 
The CMCS not only simplifies administrative processes but also equips users with the skills needed to tackle real-world challenges in the ever-evolving field of software development.
