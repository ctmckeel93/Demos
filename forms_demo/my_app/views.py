from django.shortcuts import render, redirect
from .models import User 
from .forms import RegisterForm, LoginForm 

# Create your views here.
def index(request):
    form = RegisterForm()
    form2 = LoginForm()
    context = {
        "regForm" : form,
        "logForm" : form2,
    }
    return render(request, 'index.html', context)

def register(request):
    fname = request.POST['first_name']
    lname = request.POST['last_name']
    email = request.POST['email']
    password = request.POST['password']
    user = User.objects.create(first_name=fname, last_name=lname, email=email, password=password)
    user.save()
    request.session['logged_in'] = user.id 
    return redirect('/')