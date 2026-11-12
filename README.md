# Torres Inventory System

A desktop-based inventory management system built with **C# Windows Forms** and **Microsoft Access (`sampledb.accdb`)**, featuring a unified Forest Green interface and complete CRUD operations.

**Developer:** Jovany Carl M. Torres  
**Program & Section:** BSIS-3D — Bulacan Polytechnic College  

---

## Key Features

* **User Authentication:** Sign In and Account Registration with masked password fields (`UseSystemPasswordChar`) connected to the `Users` table.
* **Inventory CRUD Operations:** Create, Read, Update, and Delete product records in real time using `OleDbConnection` and `DataGridView`.
* **Automated Stock Monitoring:** Dynamically calculates and displays **Total Items**, **Low Stock**, and **Out of Stock** counts based on quantity and reorder levels.
* **Live Search & Filtering:** Instant keyword search across product names and categories.
* **Session Management:** Logout confirmation dialog to prevent accidental sign-outs.

---

## Tech Stack

* **Language & Framework:** C# (.NET Windows Forms)
* **Database:** Microsoft Access (`sampledb.accdb` via `Microsoft.ACE.OLEDB.12.0`)
* **IDE:** Visual Studio

---

## System Screenshots

### 1. Sign In Page
<img width="1920" height="1080" alt="Screenshot (702)" src="https://github.com/user-attachments/assets/ce7f6bc2-91cc-4f6a-b36f-1df9b5815996" />


### 2. Registration Page
<img width="1920" height="1080" alt="Screenshot (703)" src="https://github.com/user-attachments/assets/d4b1c460-1390-49e8-83eb-fc042ee5d973" />


### 3. Admin Inventory Dashboard (CRUD)
<img width="1920" height="1080" alt="Screenshot (705)" src="https://github.com/user-attachments/assets/b80bc4af-324a-4598-90e4-82b8f74bb475" />
