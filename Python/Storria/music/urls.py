from django.urls import path
from . import views

app_name = "music"

urlpatterns = [
    # music/
    path('', views.IndexView.as_view(), name='index'),

    # music/10/
    path('<int:pk>/', views.DetailView.as_view(), name='detail'),

    # music/album/add/
    path('register/', views.UserFormView.as_view(), name='register'),

    # music/album/add/
    path('album/add/', views.AlbumCreate.as_view(), name='album-add'),

    # music/album/update/12
    path('album/update/<int:pk>/', views.AlbumUpdate.as_view(), name='album-update'),

    # music/album/add/
    path('album/delete/<int:pk>/', views.AlbumDelete.as_view(), name='album-delete'),

    # # music/10/favorite/
    # path('<int:album_id>/favorite/', views.favorite, name='favorite'),
]