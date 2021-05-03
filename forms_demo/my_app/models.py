from django.db import models
import re

# Create your models here.
class UserManager(models.Manager):
    def basic_validator(self, postData):
        errors = {}
        user_in_db = User.objects.filter(email=postData['email'])
        if len(postData['first_name']) < 3:
            errors['first_name'] = "Hey, your First Name need to have more than 3 characters"
        if len(postData['last_name']) < 3:
            errors['last_name'] = "Hey, your Last Name need to have more than 3 characters"
        EMAIL_REGEX = re.compile(
            r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9.+_-]+\.[a-zA-z]+$'
        )
        if not EMAIL_REGEX.match(postData['email']):
            errors['email'] = "Invalid email address"

        if len(postData['password']) < 8:
            errors['password'] = "Hey, your password need to have more than 8 characters"
        if postData['password'] != postData['confirm_password']:
            errors['password'] = "Passwords must match"


        if user_in_db:
            errors['email'] = "User already exists"
        return errors 
class User(models.Model):
    first_name = models.CharField(max_length=45)
    last_name = models.CharField(max_length=45)
    email = models.EmailField()
    password = models.CharField(max_length=15 )
    objects = UserManager()