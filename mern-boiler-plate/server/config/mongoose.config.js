const mongoose = require('mongoose')

mongoose.connect('mongodb://localhost/db_name', {
    useNewUrlParser: true,
    useUnifiedTopology: true
})

    .then(() => console.log("Connected to mongodb"))
    .catch(err => console.log("Something went wrong", err))