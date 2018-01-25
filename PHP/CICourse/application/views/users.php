<?php
$title = "All Users";
include('header.php');
?>
<span class="highlight highlight2">Administrators<span><a href="<?=base_url()?>auth/register">New Admin</a></span></span>
<table class="table">
  <thead>
    <tr>
      <th>id</th>
      <th>Username</th>
      <th>Type</th>
      <th>Added on</th>
      <th></th>
    </tr>
  </thead>
  <tbody>
  <?php foreach($admin_data as $admin):?>
      <tr>
        <td><?=$admin->id?></td>
        <td><?=$admin->username?></td>
        <td><?=($admin->type==0? "Administrator":"Moderator")?></td>
        <td><?=$admin->created?></td>
        <?php if($admin->type == 1):?>
          <td><a href="<?=base_url()."auth/rm/".$admin->id?>">Delete</a></td>
        <?php endif;?>
      </tr>
  <?php endforeach;?>
  </tbody>
</table>
