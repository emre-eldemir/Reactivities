# Reactivities Project

A full-stack web application built with .NET Core API and React TypeScript frontend.

## Technologies Used

- **Backend**: .NET Core, Entity Framework, SQLite
- **Frontend**: React 18, TypeScript, Vite
- **Styling**: CSS

## Getting Started

### Prerequisites

- .NET 9.0 SDK
- Node.js (v18 or higher)
- npm or yarn

### Backend Setup (.NET API)

1. Navigate to the API directory:
   ```bash
   cd stage1/Reactivities/API
   ```

2. Run the API with hot reload:
   ```bash
   dotnet watch
   ```

   **Hot Reload Commands:**
   - `CTRL + C` - Stop the application
   - `CTRL + R` - Restart the application

### Frontend Setup (React)

1. Navigate to the client directory:
   ```bash
   cd stage1/Reactivities/client
   ```

2. Install dependencies:
   ```bash
   npm install
   ```

3. Start the development server:
   ```bash
   npm run dev
   ```

### Creating a New React Project (Reference)

To create a new React TypeScript project with Vite:

```bash
npm create vite@latest
# Select: React
# Select: TypeScript + SWC
```

## Project Notes

### React Version Compatibility

- Current course uses React 19.0.0
- Our components are compatible with React 18
- To downgrade React version:
  1. Update version in `package.json`
  2. Run `npm install`

### Development Tools

- **Type Generation**: [JSON to TypeScript Converter](https://transform.tools/json-to-typescript)

## Project Structure

```
Reactivities/
├── API/                 # .NET Core Web API
├── Application/         # Application layer
├── Domain/             # Domain entities
├── Persistence/        # Data access layer
└── client/             # React frontend
```

## API Endpoints

- `GET /api/activities` - Get all activities

## Common Issues

### CORS Error
If you encounter CORS errors, ensure the API is configured to allow requests from the React development server (usually `http://localhost:5173`).
