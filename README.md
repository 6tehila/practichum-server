# Practichum Server

This project is a backend server designed for managing and processing data for the Practichum platform. It handles API requests and communicates with the database to ensure smooth operation of the system.

## Features

- **Data Management**: Handles CRUD operations for different data entities.
- **API Handling**: Provides endpoints for client-side requests.
- **Database Integration**: Seamless communication with the database.

## Technologies Used

- **Node.js**: Backend runtime environment.
- **Express.js**: Web framework for handling HTTP requests.
- **MongoDB**: NoSQL database for storing data.
- **Mongoose**: ODM library for MongoDB.

## Setup Instructions

### Prerequisites

- Node.js (v14 or higher)
- npm (v6 or higher)
- MongoDB (installed and running)

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/6tehila/practichum-server.git
    cd practichum-server
    ```

2. Install dependencies:
    ```bash
    npm install
    ```

3. Create a `.env` file in the root directory with the following variables:
    ```
    MONGO_URI=your-mongo-uri
    PORT=your-port-number
    ```

4. Run the server:
    ```bash
    npm start
    ```

## Contributing

Feel free to submit pull requests or open issues to improve this project.

## License

This project is licensed under the MIT License.

---

# Practichum Server

הפרויקט הזה הוא שרת צד-שרת (Backend) שמיועד לניהול ועיבוד נתונים עבור פלטפורמת Practichum. השרת מטפל בבקשות API ומתקשר עם מסד הנתונים על מנת להבטיח פעולה חלקה של המערכת.

## מאפיינים

- **ניהול נתונים**: מטפל בפעולות CRUD (יצירה, קריאה, עדכון ומחיקה) עבור ישויות נתונים שונות.
- **טיפול ב-API**: מספק נקודות קצה (endpoints) לבקשות מצד הלקוח.
- **שילוב עם מסד נתונים**: תקשורת רציפה עם מסד הנתונים.

## טכנולוגיות בשימוש

- **Node.js**: סביבה להרצת קוד צד-שרת.
- **Express.js**: פריימוורק לבניית אתרי אינטרנט שמטפל בבקשות HTTP.
- **MongoDB**: מסד נתונים NoSQL לאחסון נתונים.
- **Mongoose**: ספריית ODM (Object Data Modeling) עבור MongoDB.

## הוראות התקנה

### דרישות מקדימות

- Node.js (גרסה 14 ומעלה)
- npm (גרסה 6
