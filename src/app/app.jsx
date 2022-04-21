
import React from "react";
import { Link, Outlet } from "react-router-dom";


export default function App() {
  return (
    <div>
      <header>
      <h1>MuskelMat</h1>
      <nav
        style={{
          borderBottom: "solid 1px",
          paddingBottom: "1rem",
        }}
      >
        <Link className="link" to="/recipes">Recept</Link> |{" "}
        <Link className="link" to="/savedrecipes">Sparade Recept</Link> |{" "}
        <Link className="link" to="/weeklymenu">Veckomatsedel</Link> |{" "}
        <Link className="link" to="/contact">Kontakt</Link> |{" "}
        <Link className="link" to="/calculatemenu">Få din Veckomatsedel</Link> |{" "}
      </nav>
      <Outlet />
      </header>
    </div>
  );
}