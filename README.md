This project designed to manage patient information and medical examination results.
The system integrates a WinForms (.NET) desktop application as the frontend with a FastAPI (Python) backend, connected to a Microsoft SQL Server database.

The main objective of this system is to provide healthcare staff with a structured and efficient way to:
    •    Authenticate employees
    •    Search and select patients
    •    Create and send examination requests to Radiology and Laboratory departments
    •    View radiology examination results
    •    View laboratory test results
    •    Display detailed medical findings and summaries

System Architecture

The application follows a client–server architecture:
    •    Frontend: WinForms (.NET, C#)
    •    Backend: FastAPI (Python) with SQLAlchemy ORM
    •    Database: Microsoft SQL Server

Core Functionalities

Examination Requests

Healthcare staff can create and submit examination requests for patients:
    •    Radiology requests (e.g., imaging studies)
    •    Laboratory test requests (e.g., blood tests, diagnostic panels)

Requests are stored in the database and routed to the appropriate department for processing.

Radiology Results
 •    Display a list of radiology results in a structured table
 •    View detailed findings and impressions
 •    Load and display associated medical images (PNG/JPG format),

Laboratory Results
 •    Display laboratory test records in a data grid
 •    View detailed diagnosis and summary information
 •    Filter results by patient (HN),

Technical Design Principles
    •    Separation of concerns between frontend and backend
    •    DTO-based data binding for structured API responses
    •    Event-driven session management
    •    RESTful API design
    •    Manual DataGridView binding for better control and flexibility

Purpose

This system was developed for educational purposes to demonstrate:
    •    Desktop application development using WinForms
    •    Backend API development using FastAPI
    •    Database integration with SQL Server
    •    Client–server communication using HTTP and JSON
    •    Practical implementation of CRUD-based medical record viewing
