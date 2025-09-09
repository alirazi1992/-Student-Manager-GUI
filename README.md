# 🎓 Student Manager GUI (C# WinForms + SQLite)

Day 20 of my 30-Day C# Project-Based Learning Plan.
A simple desktop app for managing students using WinForms and SQLite.

---

## 🚀 Features

- **➕ Add Students** with Name, Age, Major.

- **✏️ Update Students** by selecting a row and editing fields.

- **❌ Delete Students** from the list.

- **📋 View All Students** in a DataGridView.

- **💾 Persistent Storage** using SQLite (`students.db`).

- **🔍 Click row → load into input fields** for editing.

  ---

## 🛠 Tech Stack

- **C# (7.3, .NET Framework 4.7.2)**

- **Windows Forms (WinForms)**

- **SQLite database**

  - Option A: `Microsoft.Data.Sqlite`(lightweight, no native DLLs)
  - Option B:  `System.Data.SQLite` (requires native interop)
 
  ---

##  📸 Screenshots

| 🎓 | 
|------|
| ![Main](./Studentmanager.png) |

----

## 📚 Learning Goals

This project helped me practice:

- Using **SQLite** with C# (`Microsoft.Data.Sqlite`).

- Binding data to **DataGridView**.

- Implementing **CRUD (Create, Read, Update, Delete)**.

- Handling **CellClick events** for row selection.

- Managing **database persistence** in desktop apps.
