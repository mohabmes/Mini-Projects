from django.views import generic
from django.views.generic.edit import CreateView, UpdateView, DeleteView
from django.views.generic import View
from django.urls import reverse_lazy
from .models import Album, Song
from django.shortcuts import render, redirect
from django.contrib.auth import authenticate, login
from .forms import UserForm

class IndexView(generic.ListView):
    template_name = 'music/index.html'
    context_object_name = 'all_album'

    def get_queryset(self):
        return Album.objects.all()


class DetailView(generic.DetailView):
    model = Album
    template_name = 'music/detail.html'
    context_object_name = 'album'

    # def get_context_data(self, **kwargs):
    #     context = super(generic.DetailView, self).get_context_data(**kwargs)
    #     context['album'] = Album.song_set.get()
    #
    #     return context


class AlbumCreate(CreateView):
    model = Album
    fields = ['artist', 'album_title', 'genre', 'album_logo']


class AlbumUpdate(UpdateView):
    model = Album
    fields = ['artist', 'album_title', 'genre', 'album_logo']


class AlbumDelete(DeleteView):
    model = Album
    success_url = reverse_lazy('music:index')


class UserFormView(View):
    form_class = UserForm
    template_name = 'music/registration.html'

    def get(self, request):
        form = self.form_class(None)
        return render(request, self.template_name, {'form': form})


    def post(self, request):
        form = self.form_class(request.POST)

        if form.is_valid():
            user = form.save(commit=False)

            username = form.cleaned_data['username']
            password = form.cleaned_data['password']
            user.set_password(password)

            user.save()

            user = authenticate(username=username, password=password)

            if user is not None:
                if user.is_active:
                    login(request, user)
                    return redirect('music:index')

        return render(request, self.template_name, {'form': form})


# from django.shortcuts import render
# from django.http import Http404
# from requests.api import request
# from .models import Album, Song

# def index(request):
#     return render(request, 'music/index.html',  {'all_album': Album.objects.all()})
#
#
# def detail(request, album_id):
#     try:
#         album = Album.objects.get(id=album_id)
#     except Album.DoesNotExist:
#         raise Http404("Album Does Not Exist")
#     return render(request, 'music/detail.html', {'album': album, 'songs': album.song_set.all()})
#
#     # return HttpResponse("<title>Hellooooo!!</title><h1>"+ str(album_id) +"</h1>")


# def favorite(request, album_id):
#     try:
#         album = Album.objects.get(id=album_id)
#     except Album.DoesNotExist:
#         raise Http404("Album Does Not Exist")
#     try:
#         song = album.song_set.get(pk=request.POST['song'])
#     except (KeyError, Song.DoesNotExist):
#         return render(request, 'music/detail.html', {
#             'album': album, 'songs': album.song_set.all(),
#             'error_msg': 'Please select song',
#         })
#     else:
#         if song.is_fav:
#             song.is_fav = False
#         else:
#             song.is_fav = True
#         song.save()
#         return render(request, 'music/detail.html', {'album': album, 'songs': album.song_set.all()})

