from django.shortcuts import render, redirect
# from .models import Accounts
from django.http import HttpResponse
from django.contrib.auth.forms import UserCreationForm

def login(request):
				pass

def signup(request):
				if request.method == "POST":
								form = UserCreationForm(request.POST)
								if form.is_valid():
												form.save()
												return redirect('articles:list')
				else:
								form = UserCreationForm()
				return render(request, 'accounts/signup.html', {'form': form})
