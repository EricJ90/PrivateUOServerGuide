const express = require('express');

const step1Route = require('./step1');
const step2Route = require('./step2');
const step3Route = require('./step3');

const router = express.Router();

module.exports = () => {
    router.get("/", (request, response) => {
        response.render('pages/index', { pageTitle: "Welcome" });
    });

    router.use('/step1', step1Route());
    router.use('/step2', step2Route());
    router.use('/step3', step3Route());
    
    return router;
}