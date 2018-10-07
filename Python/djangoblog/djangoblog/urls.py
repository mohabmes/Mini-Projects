from django.contrib import admin
from django.urls import path, include
from . import views
from django.contrib.staticfiles.urls import staticfiles_urlpatterns
from django.conf import settings
from django.conf.urls.static import static
from django.contrib import staticfiles
from articles import views as article_view

urlpatterns = [
				path('admin/', admin.site.urls),
				path('accounts/', include('accounts.urls')),
				path('', article_view.article_list),
				path('articles/', include('articles.urls')),

]

urlpatterns += staticfiles_urlpatterns()
urlpatterns += static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)