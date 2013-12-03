$(function() {
  $('#addTaskView').hide();
  
  // タスクを追加するリンク
  var isShowAddTaskView = false;
  $('#showAddTaskViewLink').click(function() {
    $('#addTaskView').toggle();
    isShowAddTaskView = !isShowAddTaskView;
    if (isShowAddTaskView) {
      $(this).text('閉じる');
    } else {
      $(this).text('タスクを追加する');
    }
  });
});