import React from "react";
import { Routes, Route, Outlet } from "react-router-dom";
import Navigation from "../Navigation";
import Home from "../Home";
import About from "../About";
import Login from "../Login";
import NoMatch from "../ErrorViews/NoMatch";

const NavLayout = () => (
    <>
        <Navigation />
        <Outlet />
    </>
);

const MyOutlet = () => {
    return (
        <Routes>
            <Route path="/" element={<Login />} />
            <Route element={<NavLayout />}>
                <Route path="/home" element={<Home />} />
                <Route path="/about" element={<About />} />
                <Route path="*" element={<NoMatch />} />
            </Route>
        </Routes>
    );
};

export default MyOutlet;