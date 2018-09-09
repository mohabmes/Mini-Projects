from django.contrib import admin
from django.urls import path, include
from . import views
from django.contrib.staticfiles.urls import staticfiles_urlpatterns
from django.conf import settings
from django.conf.urls.static import static
from django.contrib import staticfiles


urlpatterns = [
				path('admin/', admin.site.urls),
				path('', views.index),
				path('articles/', include('articles.urls')),

]

urlpatterns += staticfiles_urlpatterns()