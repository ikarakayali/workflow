

using amorphie.core.Enums;
using amorphie.workflow.core.Dtos;
public record PostWorkflowDefinitionRequest(string name, MultilanguageText[] title, PostWorkflowEntity[]? entities, string[] tags, WorkflowStatus status, MultilanguageText[]? historyForms, string recordId);

public record PostFSMWorkflowDefinitionRequest(string name, MultilanguageText[] title, PostWorkflowEntity[] entities, string[] tags, WorkflowStatus status, MultilanguageText[]? historyForms, string recordId) : PostWorkflowDefinitionRequest(name, title, entities, tags, status, historyForms, recordId);
public record PostZeebeWorkflowDefinitionRequest(string name, MultilanguageText[] title, PostWorkflowEntity[] entities, string[] tags, WorkflowStatus status, MultilanguageText[]? historyForms, string process, string gateway, string recordId) : PostWorkflowDefinitionRequest(name, title, entities, tags, status, historyForms, recordId);

public record PostWorkflowDefinitionResponse(string name);

public record PostWorkflowEntity(string name, bool isExclusive, bool isStateManager, StatusType[] availableInStatus);