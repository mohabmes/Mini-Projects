<?php
$title = "Home :: ". $_SESSION['fullname'];
include('header.php');
?>
<div class="container">
<div class="bx">
  <a href="./main/add" class="col-sm-1 btn btn-success">New</a>
  <h3 class="col-md-offset-5">My Notes</h3>
</div>
<?php if($user_notes->num_rows()>0):?>
  <br><br>
    <table class="table table-condensed">
      <thead>
        <tr>
          <th>Title</th>
          <th>Date</th>
          <th></th>
          <th></th>
        </tr>
      </thead>
      <tbody>
      <?php foreach($user_notes->result_array() as $note):?>
        <tr>
          <td><a href="./main/note/<?=$note['id']?>"><?=$note['title']?></a></td>
          <td><p><?=$note['date']?></p></td>
          <td><a href="./main/edit/<?=$note['id']?>">Edit</a></td>
          <td><a href="./main/delete/<?=$note['id']?>">Delete</a></td>
        </tr>
      <?php endforeach;?>
      </tbody>
    </table>
  <?php else: ?>
    <div class="bg-info">No Notes</div>
  <?php endif; ?>
</div>
</body>
</html>
