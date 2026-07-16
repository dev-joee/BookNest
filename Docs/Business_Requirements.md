# Software Requirements Specification (SRS)

## BookNest - Library Management System

**Version:** 1.0
**Prepared By:** Business Analyst
**Document Type:** Software Requirements Specification (SRS)

---

# 1. Introduction

## 1.1 Purpose

The purpose of this document is to define the functional and non-functional requirements for the BookNest Library Management System.

The system aims to digitize library operations by allowing librarians to manage books, members, and borrowing activities while providing members with a simple interface to browse and borrow books.

---

## 1.2 Project Scope

The system will allow administrators to manage the entire library system, librarians to maintain books and borrowing operations, and members to browse books and manage their borrowing history.

The application will be developed using ASP.NET Core MVC with SQL Server as the database.

---

## 1.3 Intended Audience

* Client
* Business Analyst
* Project Manager
* UI/UX Designer
* Developers
* QA/Testers

---

# 2. Business Objectives

The system should:

* Replace manual library records.
* Track all books in the library.
* Maintain member information.
* Track borrowing and returning operations.
* Prevent borrowing unavailable books.
* Generate useful reports.

---

# 3. User Roles

---

## Administrator

Responsible for system administration.

Permissions:

* Manage librarians
* Manage categories
* View reports
* Manage users
* View dashboard

---

## Librarian

Responsible for daily library operations.

Permissions:

* Manage books
* Manage authors
* Manage members
* Borrow books
* Return books
* View borrowing history

---

## Member

Library customer.

Permissions:

* Register account
* Login
* Browse books
* Borrow books
* Return books
* View borrowing history
* Update profile

---

# 4. Functional Requirements

---

# Module 1 — Authentication

## Description

Users should be able to create an account and access the system according to their assigned role.

### Functional Requirements

FR-1

The system shall allow users to register.

FR-2

The system shall allow registered users to login.

FR-3

The system shall allow users to logout.

FR-4

The system shall allow users to change their password.

FR-5

The system shall restrict pages based on user roles.

---

# Module 2 — Dashboard

## Description

After successful login, users should see a dashboard appropriate to their role.

### Dashboard Statistics

* Total Books
* Available Books
* Borrowed Books
* Members
* Active Borrowings

---

# Module 3 — Category Management

## Description

Administrators can manage book categories.

### Fields

* Category Name
* Description

### Functional Requirements

FR-6

Add category.

FR-7

Edit category.

FR-8

Delete category.

FR-9

Search category.

FR-10

View category list.

---

# Module 4 — Author Management

### Fields

* Author Name
* Biography

### Functional Requirements

FR-11

Create author.

FR-12

Update author.

FR-13

Delete author.

FR-14

Search author.

FR-15

View author details.

---

# Module 5 — Book Management

## Description

Librarians manage books inside the system.

### Book Information

* Title
* ISBN
* Description
* Publication Date
* Quantity
* Cover Image
* Category
* Author

### Functional Requirements

FR-16

Add new book.

FR-17

Edit book.

FR-18

Delete book.

FR-19

Upload cover image.

FR-20

Search by title.

FR-21

Search by ISBN.

FR-22

Filter by category.

FR-23

View book details.

---

# Module 6 — Member Management

### Member Information

* Full Name
* Email
* Phone
* Address
* Date of Birth

### Functional Requirements

FR-24

Create member.

FR-25

Edit member.

FR-26

Delete member.

FR-27

Search member.

FR-28

View member profile.

---

# Module 7 — Borrowing

## Description

A librarian can lend books to members.

### Borrow Information

* Member
* Book
* Borrow Date
* Due Date

### Functional Requirements

FR-29

Borrow a book.

FR-30

Decrease available quantity.

FR-31

Record borrowing history.

FR-32

Prevent borrowing unavailable books.

FR-33

Prevent duplicate active borrowing.

---

# Module 8 — Returning

### Return Information

* Borrow Record
* Return Date

### Functional Requirements

FR-34

Return borrowed book.

FR-35

Increase available quantity.

FR-36

Update borrowing history.

FR-37

Calculate overdue period.

---

# Module 9 — Profile Management

### Functional Requirements

FR-38

Update personal information.

FR-39

Upload profile image.

FR-40

Change password.

---

# Module 10 — Reports

Administrators can generate reports.

Available reports:

* Total Books
* Borrowed Books
* Available Books
* Most Borrowed Books
* Overdue Borrowings
* Active Members

---

# 5. Business Rules

---

## BR-1

Book ISBN must be unique.

---

## BR-2

Book quantity cannot become negative.

---

## BR-3

A member cannot borrow more than five books simultaneously.

---

## BR-4

A member cannot borrow the same book twice before returning it.

---

## BR-5

Books with zero quantity cannot be borrowed.

---

## BR-6

Returning a book increases available quantity.

---

## BR-7

Deleted categories cannot have assigned books.

---

## BR-8

Deleted authors cannot have assigned books.

---

## BR-9

Deleted books with active borrow records are not allowed.

---

# 6. Validation Requirements

---

## Category

| Field | Validation            |
| ----- | --------------------- |
| Name  | Required              |
| Name  | Maximum 50 characters |

---

## Author

| Field     | Validation              |
| --------- | ----------------------- |
| Name      | Required                |
| Biography | Maximum 1000 characters |

---

## Book

| Field       | Validation    |
| ----------- | ------------- |
| Title       | Required      |
| ISBN        | Required      |
| ISBN        | Unique        |
| Quantity    | Minimum 0     |
| Cover Image | JPG, PNG only |

---

## Member

| Field | Validation  |
| ----- | ----------- |
| Name  | Required    |
| Email | Required    |
| Email | Valid email |
| Phone | Required    |

---

## Borrow

| Field    | Validation                |
| -------- | ------------------------- |
| Due Date | Must be after Borrow Date |

---

# 7. Search Requirements

Users should be able to search using the following criteria:

### Books

* Title
* ISBN
* Category
* Author

### Members

* Name
* Email

### Borrowing

* Member
* Book
* Borrow Date

---

# 8. Sorting Requirements

Books can be sorted by:

* Title
* Publication Date
* Quantity

Members can be sorted by:

* Name
* Registration Date

Borrowing records can be sorted by:

* Borrow Date
* Due Date

---

# 9. Pagination Requirements

The following pages shall support pagination:

* Books
* Categories
* Authors
* Members
* Borrow History

Default page size:

10 records per page.

---

# 10. Notifications

The system should display success messages when:

* Book added
* Book updated
* Book deleted
* Category created
* Borrow completed
* Return completed

The system should display error messages when:

* Validation fails
* Duplicate ISBN exists
* Book unavailable
* Borrow limit exceeded

---

# 11. Non-Functional Requirements

## Performance

* Pages should load within 3 seconds under normal conditions.
* Search results should be returned in under 2 seconds.

---

## Security

* Passwords must be encrypted.
* Role-based authorization must be implemented.
* Users may access only authorized pages.
* Protection against SQL Injection and Cross-Site Request Forgery (CSRF) shall be implemented.

---

## Usability

* Responsive design for desktop, tablet, and mobile devices.
* Simple and intuitive navigation.

---

## Reliability

* The application should maintain data consistency during borrowing and returning operations.
* All unexpected errors should be logged.

---

## Availability

* The system should be available during library working hours.
* Database backups should be performed regularly.

---

# 12. Database Entities

### Category

* CategoryId
* Name
* Description

---

### Author

* AuthorId
* Name
* Biography

---

### Book

* BookId
* Title
* ISBN
* Description
* PublicationDate
* Quantity
* CoverImage
* CategoryId
* AuthorId

---

### Member

* MemberId
* FullName
* Email
* Phone
* Address
* DateOfBirth

---

### BorrowRecord

* BorrowRecordId
* MemberId
* BookId
* BorrowDate
* DueDate
* ReturnDate
* Status

---

### User (Identity)

* UserId
* Username
* Email
* PasswordHash
* Role

---

# 13. Assumptions

* Each book belongs to one category.
* Each book has one author.
* A member may borrow multiple books.
* A book may be borrowed multiple times over its lifetime.
* The system uses role-based access control.
* All dates are stored using the server's local time.

---

# 14. Future Enhancements

* Book reservation system.
* Barcode/QR code support.
* Email notifications for due dates.
* Fine calculation and payment tracking.
* Export reports to PDF and Excel.
* Audit logs for administrative actions.
* Dark mode support.
* REST API for mobile application integration.
