@extends('layouts.app')

@section('content')
	<div class="panel panel-default">
		<div class="panel-body">
			<form class="form-horizontal" method="POST" action="{{url('task')}}">

				
				{{csrf_field()}}

			  <div class="form-group">
			  <label for="name" class="col-sm-3 control-label" >Task</label>
				<div class="col-sm-6">
				  <input type="text" class="form-control" id="name" name="name" placeholder="Write The Task here *">
				</div>
			  </div>


			  <div class="form-group">
				<div class="col-sm-6 col-sm-offset-3">
				  <button type="submit" class="btn btn-primary" name="add">Add Task</button>
				</div>
			  </div>

			</form>
		</div>
	</div>
	
	@if($tasks->count())
		<div class="panel panel-default">
			<div class="panel-heading">
				<span>Our Current Tasks</span>
			</div>
			<div class="panel-body">
				<table class="table table-striped">
					<thead>
						<th>Task</th>
						<th>&nbsp;</th>
					</thead>
					<tbody>
						@foreach($tasks as $task)
							<tr>
								<td>{{ $task->name }}</td>
								<td>
									<form action="{{url('task/'. $task->id)}}" method="POST">
										<button type="submit" class="btn btn-danger">Delete</button>
										{{csrf_field()}}
										{{method_field('DELETE')}}
									</form>
								</td>
							</tr>
						@endforeach
					</tbody>
				</table>
			</div>
		</div>
	@endif
	
@endsection