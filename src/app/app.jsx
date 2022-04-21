
import React from "react";
import { Link, Outlet } from "react-router-dom";


export default function App() {
  return (
    <div>
      <h1>MuskelMat</h1>
      <nav
        style={{
          borderBottom: "solid 1px",
          paddingBottom: "1rem",
        }}
      >
        <Link to="/recipes">Recept</Link> |{" "}
        <Link to="/savedrecipes">Sparade Recept</Link> |{" "}
        <Link to="/weeklymenu">Veckomatsedel</Link> |{" "}
        <Link to="/contact">Kontakt</Link> |{" "}
      </nav>
      <Outlet />
    </div>
  );
}