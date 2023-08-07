import React from 'react';
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';
import Home from './Home'
const Login = () => {

    return (
        <div>
            <Link to="/home" style={{ padding: 5 }}>
                Login
            </Link>

            
        </div>
    );
};

export default Login;
