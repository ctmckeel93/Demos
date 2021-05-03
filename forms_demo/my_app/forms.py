from django import forms
from .models import User

class RegisterForm(forms.ModelForm):
    class Meta:
        model = User 
        fields = "__all__"
        widgets = {
            "first_name" : forms.TextInput(attrs={ "class":"form-control"}),
            "last_name" : forms.TextInput(attrs={ "class":"form-control"}),
            "email" : forms.TextInput(attrs={ "class":"form-control"}),
            "password" : forms.TextInput(attrs={ "class":"form-control"})
        }

class LoginForm(forms.ModelForm):
    class Meta: 
        model = User 
        fields =("email", "password")
        