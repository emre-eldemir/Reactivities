import { useEffect, useState } from "react";
// Import Activity type
// Import Activity type
import type { Activity } from "./lib/types";

function App() {
  // const title='Reactivities v2';

  // const [activities, setActivities] = useState<string[]>([]);
  const [activities, setActivities] = useState<Activity[]>([]);

  useEffect(() => {
    fetch('https://localhost:5001/api/activities')
      .then(response => response.json())
      .then(data => setActivities(data))
     // .catch(error => console.error('Error fetching activities:', error));

      return () => {}
  }, []);

  return (
    <div>

      <h3 className="app" style={{ color: 'red' }}>Reactivities</h3>
      
      <ul>
        {activities.map(activity => (
          <li key={activity.id}>{activity.title}</li>
        ))}
      </ul>
    </div>
  )
}

export default App
