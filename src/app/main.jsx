import { createRoot } from 'react-dom/client';
import {
    BrowserRouter,
    Routes,
    Route,
} from "react-router-dom";
import App from './app.jsx';
import Contact from "./routes/contact";
import Recipes from "./routes/recipes";
import Recipe from './routes/recipe';
import SavedRecipes from "./routes/savedrecipes";
import WeeklyMenu from "./routes/weeklymenu";

const container = document.getElementById("root");
const root = createRoot(container);

root.render(
    <BrowserRouter>
        <Routes>
            <Route path="/" element={<App />}>
                <Route path="contact" element={<Contact />} />
                <Route path="recipes" element={<Recipes />}>
                    <Route
                        index
                        element={
                            <main style={{ padding: "1rem" }}>
                                <h2>Välj ett recept!</h2>
                            </main>
                        }
                    />
                    <Route path=":recipeId" element={<Recipe />} />
                </Route>
                <Route path="savedrecipes" element={<SavedRecipes />} />
                <Route path="weeklymenu" element={<WeeklyMenu />} />
                <Route
                    path="*"
                    element={
                        <main style={{ padding: "1rem" }}>
                            <p>There's nothing here!</p>
                        </main>
                    }
                />
            </Route>
        </Routes>
    </BrowserRouter>
)