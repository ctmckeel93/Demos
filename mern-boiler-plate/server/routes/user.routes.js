const UserController = require('../controllers/user.controller');
 
module.exports = app => {
    app.get('/api/users', UserController.findAll);
    app.get('/api/users/:id', UserController.findOne);
    app.put('/api/users/:id', UserController.update);
    app.post('/api/users', UserController.create);
    app.delete('/api/users/:id', UserController.delete);
}