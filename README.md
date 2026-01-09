# Geography Quiz Application

This project is a desktop-based **Geography Quiz Application** with a graphical user interface.

It allows users to test their knowledge of **countries, capitals, and flags** through configurable quiz sessions while keeping track of players and high scores using a database.

The application supports multiple windows, persistent data storage, and full user and score management.

---

## Features

### User Management
- Register new players  
- Select existing players from the database  
- Delete players if no longer needed  

### Quiz Configuration
- Choose what the user has to guess and what is used as the clue:
  - Country name
  - Capital city
  - Flag image
- Each quiz round consists of **10 randomly selected questions**
- Answer options are generated dynamically:
  - One correct answer
  - Multiple distractors

### Gameplay
- Dedicated quiz window for playing  
- Immediate feedback after each answer (**correct / incorrect**)  
- Points are awarded per question and summed up for the round  
- Flag images are displayed when flags are used as clues or answers  

### Score System
- Scores are stored permanently in the database  
- View high scores in a separate window  
- Display:
  - Scores per player
  - Overall score overview
- Scores can be deleted if required  

### Database Integration
- Connects to a relational database to:
  - Load countries, capitals, and flags
  - Manage registered players
  - Store and retrieve quiz results
- All relevant data is handled dynamically at runtime
- 
---

## Technologies

- **Programming Language:** C#  
- **Framework:** .NET  
- **Database:** MySQL  
- **GUI:** Windows Forms / WPF  

