from django.shortcuts import render
# from .models import Accounts
from django.http import HttpResponse
from django.contrib.auth.forms import UserCreationForm

def login(request):
				pass

def signup(request):
				form = UserCreationForm()

				return render(request, 'accounts/signup.html', {'form': form})
