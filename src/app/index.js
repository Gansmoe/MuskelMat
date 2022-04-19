import { createRoot } from 'react-dom/client';
import { Navbar } from './components/navbar/Navbar.js';

const container = document.getElementById("root");
const root = createRoot(container);

root.render(<Navbar />)