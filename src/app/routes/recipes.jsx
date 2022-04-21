import {
  NavLink,
  Outlet,
  useSearchParams,
} from "react-router-dom";
import { getRecipes } from "../data/mockdata.js";


export default function Recipes() {
  let recipes = getRecipes();
  console.log(recipes);
  let [searchParams, setSearchParams] = useSearchParams();
  return (
    <div style={{ display: "flex" }}>
      <nav
        style={{
          borderRight: "solid 1px",
          padding: "1rem",
        }}
      >
        <input
          value={searchParams.get("filter") || ""}
          onChange={(event) => {
            let filter = event.target.value;
            if (filter) {
              setSearchParams({ filter });
            } else {
              setSearchParams({});
            }
          }}
        />

        {recipes
          .filter((recipe) => {
            let filter = searchParams.get("filter");
            if (!filter) return true;
            let name = recipe.name.toLowerCase();
            return name.startsWith(filter.toLowerCase());
          })
          .map((recipe) => (
            <NavLink
              style={({ isActive }) => {
                return {
                  display: "block",
                  margin: "1rem 0",
                  color: isActive ? "red" : "",
                };

              }}
              to={`/recipes/${recipe.number}`}
              key={recipe.number}
            >
              {recipe.name}
            </NavLink>
          ))}
      </nav>
      <Outlet />
    </div>
  );
}
